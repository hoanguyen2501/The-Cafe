/* eslint-disable react/jsx-pascal-case */

import React, { useEffect, useState } from "react";
import { getCustomers } from "../../app/ApiResult";
import Table_Person from "./../Table_Person/index";

function Customers(props) {
  const List_Title_Head = [
    { Name: "Mã số" },
    { Name: "Họ tên" },
    { Name: "Địa chỉ" },
    { Name: "Số điện thoại" },
    { Name: "Xóa" },
    { Name: "Cập nhật" },
  ];
 
  const [data, setData] = useState();
  const [paginate, setPaginate] = useState({
    page:1,
    size:10
  });
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const res=await getCustomers(paginate);
    setData(res?.data)
  }, [paginate]);
  return <Table_Person List={data} List_Title_Head={List_Title_Head} paginate={paginate} setPaginate={setPaginate}/>;
}

export default Customers;
