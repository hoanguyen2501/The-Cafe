/* eslint-disable react/jsx-pascal-case */
import React, { useContext, useEffect, useState } from 'react';
import { getProduct } from '../../app/ApiResult';
import { context } from '../../app/Context';
import TableProduct from '../TableProduct/index';

function ProductList(props) {
  const [data, setData] = useState();
  const [dataSet, setDataSet] = useState();
  const [flag,setFlag]=useState();
  const Context=useContext(context)
  const {TypeDataPro, setTypeDataPro}=Context
  // eslint-disable-next-line react-hooks/exhaustive-deps
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 8,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getProduct(paginate);
    setData(res.data);
    setPaginate({
      ...paginate,
      count: res.totalPages,
    });
    setFlag(false)
  // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [flag]);
  const ListTitleHead = [
    { Name: 'Mã số' },
    { Name: 'Tiêu đề' },
    { Name: 'Giá' },
    { Name: 'Xóa' },
    { Name: 'Cập nhật' },
    { Name: 'Chi tiết' },
  ];

  useEffect(() => {
    switch (TypeDataPro) {
      case 'COFFEES': {
        setDataSet(data);
        break;
      }
      case 'BOOKS': {
        setDataSet([]);
        break;
      }
      case 'NEWS': {
        setDataSet([]);
        break;
      }
      default: {
        setDataSet(data);
        break;
      }
    }
  }, [TypeDataPro, data]);
  return (
    <>
  
      <ul className='nav nav-tabs' id='myTab' role='tablist'>
        <li className='nav-item' role='presentation'>
          <button
            onClick={() => setTypeDataPro('COFFEES')}
            className={`nav-link ${TypeDataPro==='COFFEES'&&'active'}`}
            id='home-tab'
            data-bs-toggle='tab'
            data-bs-target='#home'
            type='button'
            role='tab'
            label={'Show'}
            aria-controls='home'
            aria-selected='true'>
            Coffees
          </button>
        </li>
        <li className='nav-item' role='presentation'>
          <button
            onClick={() => setTypeDataPro('BOOKS')}
            className={`nav-link ${TypeDataPro==='BOOKS'&&'active'}`}
            id='profile-tab'
            data-bs-toggle='tab'
            data-bs-target='#profile'
            type='button'
            role='tab'
      
            aria-controls='profile'
            aria-selected='false'>
            Books
          </button>
        </li>
        <li className='nav-item' role='presentation'>
          <button
            onClick={() => setTypeDataPro('NEWS')}
            className={`nav-link ${TypeDataPro==='NEWS'&&'active'}`}
            id='contact-tab'
            data-bs-toggle='tab'
            data-bs-target='#contact'
            type='button'
            role='tab'
            aria-controls='contact'
            aria-selected='false'>
            News
          </button>
        </li>
      </ul>

      <TableProduct
        ListTitleHead={ListTitleHead}
        List={dataSet}
        paginate={paginate}
        setFlag={setFlag}
        setPaginate={setPaginate}
      />
    </>
  );
}

export default ProductList;
