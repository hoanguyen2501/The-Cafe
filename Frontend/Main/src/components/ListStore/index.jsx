/* eslint-disable react-hooks/exhaustive-deps */
import React, { useEffect, useState } from 'react';
import { useHistory } from 'react-router-dom';
import { getStore } from '../../app/ApiResult';
import Store from './../Store/Store';
import './styles.scss';

function ListStore(props) {
  const queryParams = new URLSearchParams(window.location.search)
  const history=useHistory();

  const [stores, setStores] = useState([]);
  const [listFillter, setListFillter] = useState([]);
  function ChangeActive(index, filter) {
    const Loaiactive = document.querySelector('.StoreTag.active');
    const listLoai = document.querySelectorAll('.StoreTag');
    if (Loaiactive) {
      Loaiactive.classList.remove('active');
    }
    listLoai[index].classList.add('active');
    history.push(`/Store?type=${filter}`)
  }
  const fetch= async ()=>{
     const res= await getStore();
     if(res){
      setStores(res)
     }
  }

  const ListC = [
    {
      cityName: 'Tất cả cửa hàng',
      Count: 4,
      id: 0,
    },
    {
      cityName: 'Quận 1',
      Count: 4,
      id: 1,
    },
    {
      cityName: 'Quận 2',
      Count: 0,
      id: 2,
    },
    {
      cityName: 'Quận 3',
      Count: 7,
      id: 3,
    },
    {
      cityName: 'Quận 4',
      Count: 10,
      id: 4,
    },
  ];
  useEffect(()=>{
    fetch();
  },[queryParams.get('type')])
  useEffect(() => {
    const filter =Number(queryParams.get('type'));
    if (filter!==0) {
      let temp=stores?.filter(item=>item?.Address===filter);
      setListFillter(temp);

    } else {
      setListFillter(stores);
    }
  }, [Number(queryParams.get('type')),stores]);
  return (
    <div className='List_Store'>
      <div className='List_country'>
        <div className='Title'>
          <i className='fas fa-store-alt'></i>
          <h3>Khám phá 180 cửa hàng TCH</h3>
        </div>
      </div>
      <div className='bodyCountry'>
        <ul className='Countrys'>
          {ListC?.map((item, index) => (
            <li key={index}
              className={`StoreTag ${ Number(queryParams.get('type'))===item?.id && 'active'}`}
              onClick={() => ChangeActive(index, item?.id)}>
              <p>
                {item.cityName} ({item?.Count})
              </p>
            </li>
          ))}
        </ul>
        <div className='Stores'>
          {listFillter?
            listFillter?.map((item,index)=>(
               <Store key={index} item={item} />
            )):<h5>Chưa có của hàng nào !</h5>
          }
        
        </div>
      </div>
    </div>
  );
}

export default ListStore;
