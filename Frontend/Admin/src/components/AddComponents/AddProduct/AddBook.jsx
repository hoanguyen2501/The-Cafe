/* eslint-disable jsx-a11y/alt-text */
import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import { useSnackbar } from 'notistack';
import React, { useState } from 'react';
import './styles/AddBook.scss';

function AddBook(props) {
  const [valueData, setValueData] = useState({
    Id: undefined,
    Name: '',
    Photo: '',
    ProductTypeId: '',
    SupplierId: '',
    Description: '',
    Price: '',
    Size: '',
  });

  const handleChangeData = (event) => {
    setValueData({ ...valueData, [event.target.name]: [event.target.value].toString() });
  };
  const { enqueueSnackbar } = useSnackbar();
  const [image, setImage] = useState();
  const [urlImage, setUrlimage] = useState(undefined);
  var HandleChange = (e) => {
    const file = e.target?.files[0];
    if (file) {
      const fileType = file['type'];
      const validImageTypes = ['image/gif', 'image/jpeg', 'image/png'];
      if (!validImageTypes.includes(fileType)) {
        enqueueSnackbar('Sai định dạng', { variant: 'error' });
        setUrlimage(undefined);
      } else {
        if (file) {
          file.preview = URL.createObjectURL(file);
          setImage(file);
        }
      }
    }
  };
   const HandleUpload = () => {
    if (image) {
      enqueueSnackbar('Tải lên thành công', { variant: 'success' });
    } else {
      enqueueSnackbar('Hãy chọn tệp tin', { variant: 'warning' });
    }
  };
 
  return (
    <div className='AddBook'>
      
      <Fade in={true} timeout={200} style={{ height: '100%' }}>
        <Paper>
          <h2 className='text-center pt-2'>Thêm sách mới</h2>

          <div className='dataAdd'>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='Name'
                color='warning'
                value={valueData.Name}
                onChange={handleChangeData}
              />
              <label htmlFor='floatingInput'>Tiêu đề</label>
            </div>

            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control'
                name='Price'
                color='warning'
                value= {valueData.Price}
                onChange={handleChangeData}
              />
             
              <label htmlFor='floatingInput'>Giá</label>
            </div>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='ProductTypeId'
                color='warning'
                value={valueData.ProductTypeId}
                onChange={handleChangeData}
              />
              <label htmlFor='floatingInput'>productTypeId</label>
            </div>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='SupplierId'
                color='warning'
                value={valueData.SupplierId}
                onChange={handleChangeData}
              />
              <label htmlFor='floatingInput'>supplierId</label>
            </div>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='Size'
                color='warning'
                value={valueData.Size}
                onChange={handleChangeData}
              />
              <label htmlFor='floatingInput'>Size</label>
            </div>
            <div className='form-floating mb-3 inputData'></div>
            <input type='file' id='inputFile' onChange={HandleChange} />
     
            
            <label className='inputFileLabel inputData ' htmlFor='inputFile'>
              <div className='box_input'>
                <p className='text-center textUpload '>Hình ảnh mô tả</p>
                {image && <img className='img_preview' src={image.preview} />}
                <i className='fad fa-plus-circle iconUpLoad'></i>
              </div>
            </label>
        
            <div className='form-floating inputData'>
              <textarea
                className='form-control'
                placeholder='Leave a comment here'
                id='floatingTextarea2'
                name='Description'
                color='warning'
                value={valueData.Description}
                onChange={handleChangeData}
                style={{ height: '200px' }}></textarea>
              <label className='description' htmlFor='floatingTextarea2'>
                Nội dung
              </label>
            </div>
        
          
            <div>
              <button type="submit" className='btn btn-success inputData' style={{minWidth:"200px"}} onClick={HandleUpload}>Thêm sản phẩm</button>
            </div>
          </div>
        </Paper>
      </Fade>
    </div>
  );
}

export default AddBook;
