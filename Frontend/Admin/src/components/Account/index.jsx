/* eslint-disable react/jsx-pascal-case */
import React from 'react';
import data from '../../data';
import Table_Account from '../TableAccount';
function Account(props) {
    const ListTitleHead=[
        
        {Name:"Mã số"},
        {Name:"Họ tên"},
        {Name:"Gmail"},
        {Name:"Số điện thoại"},
        {Name:"Xóa"},
        {Name:"Cập nhật"},   
]

return (    
        <Table_Account List={data.Account_data} ListTitleHead={ListTitleHead}/>
);
}



export default Account;