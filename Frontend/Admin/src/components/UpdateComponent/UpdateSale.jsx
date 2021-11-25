/* eslint-disable jsx-a11y/alt-text */
import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import React, { useContext, useState } from 'react';
import { context } from '../../app/Context';
import Sales from './../Sales/index';
import './stylesUpdateComponent/UpdateSale.scss';
function UpdateSale(props) {
  const Context = useContext(context);
  const { setBodyAdmin, setFillerAdmin } = Context;
  const [valueData, setValueData] = useState({
    Id: '',
    Name: '',
    Email: '',
    Phone: '',
    Age:'',
    Gender:'',
    Address:''
  });

  const { id } = props;
  function Prev() {
    setBodyAdmin(<Sales />);
    setFillerAdmin('SALES');
  }
  const handleChange = (event) => {
    setValueData({ ...valueData, [event.target.name]: [event.target.value] });
  };
  return (
    <div className='UpdateSale'>
      <Fade in={true} timeout={200} style={{ height: '100%' }}>
        <Paper>
          <button
            type='button'
            className='btn btn-success d-flex gap-2'
            onClick={() => Prev()}>
            <i
              style={{ fontSize: '1.5rem' }}
              className='fad fa-chevron-circle-left'></i>
            <p className> Quay lại</p>
          </button>
          <h2 className='text-center'>Cập nhật nhân viên </h2>
          <p  style={{width:'80%',margin:'0 auto'}}>Mã nhân viên:{id}</p>
          <div className='dataUpdate'>
            
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='Name'
                color='warning'
                value={valueData.Name}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Họ và Tên</label>
            </div>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='Email'
                color='warning'
                value={valueData.Email}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Email</label>
            </div>
            <div className='form-floating mb-3 inputData' >
              <input
                type='text'
                className='form-control '
                name='Phone'
                color='warning'
                value={valueData.Phone}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Số điện thoại</label>
            </div>
            <div className='form-floating mb-3 inputData' >
              <input
                type='text'
                className='form-control '
                name='Age'
                color='warning'
                value={valueData.Age}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Tuổi</label>
            </div>
            <div className='form-floating mb-3 inputData' >
              <select  className='form-control '
                name='Gender'
                color='warning'
                value={valueData.Gender}
                onChange={handleChange}>

                  <option value="Nam">Nam</option>
                  <option value="Nu">Nữ</option>
                </select>
             
              <label htmlFor='floatingInput'>Giới tính</label>
            </div>
            <div className='form-floating mb-3 inputData' >
              <input
                type='text'
                className='form-control '
                name='Address'
                color='warning'
                value={valueData.Address}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Địa chỉ</label>
            </div>
           </div>
        </Paper>
      </Fade>
    </div>
  );
}

export default UpdateSale;
