import { useEffect, useState } from 'react';
import { getProduct } from '../../app/ApiResult';
import Table_Person from '../TablePeople/index';
function Sales() {
  const ListTitleHead = [
    { Name: 'Mã số' },
    { Name: 'Họ tên' },
    { Name: 'Email' },
    { Name: 'Số điện thoại' },
    { Name: 'Xóa' },
    { Name: 'Cập nhật' },
  ];
  const [data, setData] = useState();
  const [paginate, setPaginate] = useState({
    page: 1,
    size: 10,
    count: 0,
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res = await getProduct(paginate);
    setData(res?.data);
    setPaginate({
      ...paginate,
      count: res?.totalPages,
    });
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [paginate.page]);
  return (
    // eslint-disable-next-line react/jsx-pascal-case
    <Table_Person
      ListTitleHead={ListTitleHead}
      List={data}
      paginate={paginate}
      setPaginate={setPaginate}
    />
  );
}
export default Sales;
