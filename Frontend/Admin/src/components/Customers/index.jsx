/* eslint-disable react/jsx-pascal-case */

import React, { useEffect, useState } from 'react';
import { getCustomers } from '../../app/ApiResult';
import TableCustomes from '../Table/TablePeople/Customes';

function Customers(props) {


  const [data, setData] = useState();
  const [TypeData, setTypeData] = useState();
  //   const [dataSet, setDataSet] = useState();
  const [flag, setFlag] = useState();
  // eslint-disable-next-line react-hooks/exhaustive-deps
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getCustomers(paginate);
    setData(res?.data);
  }, [paginate]);
  return (
    <TableCustomes
    List={data}
    paginate={paginate}
    setFlag={setFlag}
    setPaginate={setPaginate}
    Type={TypeData}
    />
  );
}

export default Customers;
