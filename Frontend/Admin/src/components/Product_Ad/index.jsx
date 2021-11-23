/* eslint-disable react/jsx-pascal-case */
import axios from "axios";
import React, { useEffect, useState } from "react";
import Table_Product from "./../Table_Product/index";
function Product_List(props) {
  // const [value, setValue] = React.useState('one');
  // const handleChange = (event, newValue) => {
  //   setValue(newValue);
  // };
  const [data, setData] = useState();
  const [TypeData, setTypeData] = useState();
  const [dataSet, setDataSet] = useState(1);
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async () => {
    const response = await axios("/products");

    if (response.data) {
      setData(response?.data);
    }
  }, []);

  const List_Title_Head = [
    { Name: "Mã số" },
    { Name: "Tiêu đề" },
    { Name: "Giá" },
    { Name: "Xóa" },
    { Name: "Cập nhật" },
    { Name: "Chi tiết" },
  ];

  useEffect(() => {
    setTypeData(data);
    switch (dataSet) {
      case 1: {
        setTypeData(data);
        break;
      }
      case 2: {
        setTypeData([]);
        break;
      }
      default: {
        setTypeData([]);
        break;
      }
    }
  }, [dataSet, data]);

  return (
    <>
      <ul className="nav nav-tabs" id="myTab" role="tablist">
        <li className="nav-item" role="presentation">
          <button
            onClick={() => setDataSet(1)}
            className="nav-link active"
            id="home-tab"
            data-bs-toggle="tab"
            data-bs-target="#home"
            type="button"
            role="tab"
            label="Show"
            aria-controls="home"
            aria-selected="true"
          >
            Coffees
          </button>
        </li>
        <li className="nav-item" role="presentation">
          <button
            onClick={() => setDataSet(2)}
            className="nav-link"
            id="profile-tab"
            data-bs-toggle="tab"
            data-bs-target="#profile"
            type="button"
            role="tab"
            aria-controls="profile"
            aria-selected="false"
          >
            Books
          </button>
        </li>
        <li className="nav-item" role="presentation">
          <button
            onClick={() => setDataSet(3)}
            className="nav-link"
            id="contact-tab"
            data-bs-toggle="tab"
            data-bs-target="#contact"
            type="button"
            role="tab"
            aria-controls="contact"
            aria-selected="false"
          >
            News
          </button>
        </li>
      </ul>

      <Table_Product List_Title_Head={List_Title_Head} List={TypeData} />
    </>
  );
}

export default Product_List;
