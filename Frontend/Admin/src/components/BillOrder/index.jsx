/* eslint-disable react/jsx-pascal-case */
import React, { useEffect, useState } from 'react';
import { getBill } from '../../app/ApiResult';
import TableBill from '../Table/TableBill';
function BillOrder() {
  
  const [data, setData] = useState();
  const [TypeData, setTypeData] = useState();
//   const [dataSet, setDataSet] = useState();
  const [flag,setFlag]=useState();
  // eslint-disable-next-line react-hooks/exhaustive-deps
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getBill(paginate,'/bill');
    setData(res?.data);
    console.log(res.data)
    setPaginate({
      ...paginate,
      count: res?.totalPages,
    });
    setFlag(false)
  // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [flag]);
  return (
    <TableBill
      List={data}
      paginate={paginate}
      setFlag={setFlag}
      setPaginate={setPaginate}
      Type='BILLORDER'
    />
  );
}

export default BillOrder;
