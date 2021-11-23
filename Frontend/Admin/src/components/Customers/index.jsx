/* eslint-disable react/jsx-pascal-case */
import React, { useEffect, useState } from "react";
import data from "../../data";
import Table_Person from "./../Table_Person/index";
import axios from "axios";
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
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const response = await axios("/customer");
    console.log(response.data);
    if (response.data) {
      setData(response.data);
    }
  }, []);
  return <Table_Person List={data} List_Title_Head={List_Title_Head} />;
}

export default Customers;
