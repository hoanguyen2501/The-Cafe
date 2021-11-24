/* eslint-disable jsx-a11y/alt-text */
import React, { useContext, useState } from 'react';
import { context } from '../../app/Context';
import Product from './../Product/index';
import TextField from '@mui/material/TextField';
import TextareaAutosize from '@mui/material/TextareaAutosize';
import './stylesUpdateComponent/UpdateProducts.scss';
import { useSnackbar } from 'notistack';
function UpdateProducts(props) {
  const Context = useContext(context);
  const { setBodyAdmin, setFillerAdmin } = Context;
  const [valueData, setValueData] = useState({
    Id: '',
    Title: '',
    Photo: '',
    Description: '',
    Price: '',
  });

  const { id } = props;
  function Prev() {
    setBodyAdmin(<Product />);
    setFillerAdmin('PRODUCT');
  }
  const handleChange = (event) => {
    setValueData({ ...valueData, [event.target.name]: [event.target.value] });
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
    <div className='UpdateProducts'>
      <button type='button' className='btn btn-success' onClick={() => Prev()}>
        <i
          style={{ fontSize: '1.5rem' }}
          className='fad fa-chevron-circle-left'></i>
      </button>
      <h2 className='text-center'>Cập nhật sản phẩm {id}</h2>
      <div className='dataUpdate'>
        <div class='form-floating mb-3 inputData'>
          <input
            type='text'
            class='form-control '
            name='Title'
            color='warning'
            value={valueData.Title}
            onChange={handleChange}
          />
          <label for='floatingInput'>Tiêu đề</label>
        </div>

        <div class='form-floating mb-3 inputData'>
          <input
            type='text'
            class='form-control'
            name='Price'
            color='warning'
            value={valueData.Price}
            onChange={handleChange}
          />
          <label for='floatingInput'>Giá</label>
        </div>

        <input type='file' id='inputFile' onChange={HandleChange} />
        <label className='inputFileLabel inputData ' htmlFor='inputFile'>
          <div className='box_input'>
            <p className='text-center textUpload '>Hình ảnh mô tả</p>
            {image && <img className='img_preview' src={image.preview} />}
            <i className='fad fa-plus-circle iconUpLoad'></i>
          </div>
        </label>
        <div class='form-floating inputData'>
          <textarea
            class='form-control'
            placeholder='Leave a comment here'
            id='floatingTextarea2'
            name='Description'
            color='warning'
            value={valueData.Description}
            onChange={handleChange}
            style={{ height: '200px' }}></textarea>
          <label className="description" for='floatingTextarea2'>Nội dung</label>
        </div>
      </div>
    </div>
  );
}

export default UpdateProducts;
