/* eslint-disable react/jsx-pascal-case */
import React, { useEffect, useState } from 'react';
import { getProduct } from '../../app/ApiResult';
import TableProduct from '../TableProduct/index';

function ProductList(props) {
  const [data, setData] = useState();
  const [TypeData, setTypeData] = useState('COFFEES');
  const [dataSet, setDataSet] = useState();
  const [flag,setFlag]=useState();
  // eslint-disable-next-line react-hooks/exhaustive-deps
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
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
  
  // eslint-disable-next-line react-hooks/exhaustive-deps
  // useEffect(async () => {
  //   const res = await getProduct(paginate);
  
  //   // eslint-disable-next-line react-hooks/exhaustive-deps
  // }, [paginate.page]);

  const ListTitleHead = [
    { Name: 'Mã số' },
    { Name: 'Tiêu đề' },
    { Name: 'Giá' },
    { Name: 'Xóa' },
    { Name: 'Cập nhật' },
    { Name: 'Chi tiết' },
  ];

  useEffect(() => {
    switch (TypeData) {
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
  }, [TypeData, data]);
  return (
    <>
  
      <ul className='nav nav-tabs' id='myTab' role='tablist'>
        <li className='nav-item' role='presentation'>
          <button
            onClick={() => setTypeData('COFFEES')}
            className='nav-link active'
            id='home-tab'
            data-bs-toggle='tab'
            data-bs-target='#home'
            type='button'
            role='tab'
            label='Show'
            aria-controls='home'
            aria-selected='true'>
            Coffees
          </button>
        </li>
        <li className='nav-item' role='presentation'>
          <button
            onClick={() => setTypeData('BOOKS')}
            className='nav-link'
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
            onClick={() => setTypeData('NEWS')}
            className='nav-link'
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
        Type={TypeData}
        setTypeData={setTypeData}
      />
    </>
  );
}

export default ProductList;
