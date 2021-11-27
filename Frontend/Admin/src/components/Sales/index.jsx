import { useEffect, useState } from 'react';
import { getProducts } from '../../app/ApiResult';
import TableSales from '../Table/TablePeople/Sales';
function Sales() {
  const [flag,setFlag]=useState();
  const [data, setData] = useState();
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getProducts(paginate,"/products");
    setData(res?.data);
    setPaginate({
      ...paginate,
      count: res?.totalPages,
    });
    setFlag(false)
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [flag]);
  return (
    // eslint-disable-next-line react/jsx-pascal-case
    <TableSales
      List={data}
      paginate={paginate}
      setPaginate={setPaginate}
      setFlag={setFlag}
      Type='SALES'
    />
  );
}
export default Sales;
