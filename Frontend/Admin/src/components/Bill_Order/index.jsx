/* eslint-disable react/jsx-pascal-case */
import React, { useEffect, useState } from 'react';
import { getCustomers } from '../../app/ApiResult';
import Table_Bill from '../Table_Bill';
function Analytis() {
    const List_Title_Head=[
        
            {Name:"Mã số"},
            {Name:"Họ tên"},
            {Name:"Địa chỉ"},
            {Name:"Tổng hóa đơn"},
            {Name:"Trạng thái"},
            {Name:"Hủy giao"},
            {Name:"Hoàn tất giao"},   
    ]
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
    return (    
            <Table_Bill List={data} List_Title_Head={List_Title_Head} paginate={paginate} setPaginate={setPaginate}/>
    );
}

export default Analytis;