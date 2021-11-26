import { useEffect, useState } from 'react';
import { getProducts } from '../../app/ApiResult';
import TablePerson from '../TablePeople/index';
function Sales() {
  const ListTitleHead = [
    { Name: 'Mã số' },
    { Name: 'Họ tên' },
    { Name: 'Email' },
    { Name: 'Số điện thoại' },
    { Name: 'Xóa' },
    { Name: 'Cập nhật' },
  ];
  const [flag,setFlag]=useState();
  const [data, setData] = useState();
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getProducts(paginate);
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
    <TablePerson
      ListTitleHead={ListTitleHead}
      List={data}
      paginate={paginate}
      setPaginate={setPaginate}
      setFlag={setFlag}
      Type='SALES'
    />
  );
}
export default Sales;
