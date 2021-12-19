import React, { memo } from 'react';
import Store from './../Store/Store';
import './styles.scss';

function ListStore(props) {
  // const [Filter, SetFilter] = useState("");
  //   const [List_Fillter, SetList_Fillter] = useState("");
  function ChangeActive(index, filter) {
    const Loaiactive = document.querySelector('.StoreTag.active');
    const listLoai = document.querySelectorAll('.StoreTag');
    if (Loaiactive) {
      Loaiactive.classList.remove('active');
    }
    listLoai[index].classList.add('active');
    // SetFilter(filter);
  }
  //   useEffect(() => {
  //     // const Temp = [];
  //     // SetList_Fillter(Temp);
  //   }, [Filter]);
  const ListC = [
    {
      City_Name: 'Quận 1',
      Count: 4,
    },
    {
      City_Name: 'Quận 2',
      Count: 0,
    },
    {
      City_Name: 'Quận 3',
      Count: 7,
    },
    {
      City_Name: 'Quận 4',
      Count: 10,
    },
  ];
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
            <li className={`StoreTag ${!index&&'active'}`} onClick={() => ChangeActive(index)}>
              <p>{item.City_Name} ({item?.Count})</p>
            </li>
          ))}
        </ul>
        <div className='Stores'>
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
          <Store />
        </div>
      </div>
    </div>
  );
}

export default memo(ListStore);
