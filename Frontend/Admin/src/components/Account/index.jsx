/* eslint-disable react/jsx-pascal-case */
import React, { useEffect, useState } from 'react';
import { getAccounts } from '../../app/ApiResult';
import data1 from '../../data';
import TableAccount from '../Table/TableAccount';
function Account(props) {
 
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
        const res = await getAccounts(paginate,"/account");
        setData(res?.data);
        setPaginate({
          ...paginate,
          count: res?.totalPages,
        });
        setFlag(false)
      // eslint-disable-next-line react-hooks/exhaustive-deps
      }, [flag]);

return (
  <TableAccount
    List={data}
    paginate={paginate}
    setFlag={setFlag}
    setPaginate={setPaginate}
    Type={TypeData}
  />
);
}



export default Account;