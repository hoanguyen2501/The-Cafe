/* eslint-disable jsx-a11y/alt-text */
import Checkbox from '@mui/material/Checkbox';
import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import { useSnackbar } from 'notistack';
import React, { useContext, useEffect, useState } from 'react';
import { getProductId, updateProduct } from '../../app/ApiResult';
import { context } from '../../app/Context';
import Product from '../Product';
import './stylesUpdateComponent/UpdateCoffees.scss';
function UpdateCoffee(props) {
  const Context = useContext(context);
  const { id } = props;
  const { setBodyAdmin, setFillerAdmin } = Context;
  const [valueData, setValueData] = useState({
    Id: undefined,
    Name: '',
    Photo: '',
    ProductTypeId: undefined,
    SupplierId: undefined,
    Description: '',
    Price: undefined,
    Size: undefined,
  });
   
  // eslint-disable-next-line react-hooks/exhaustive-deps
  useEffect(async() => {
    const result = await getProductId(id,"/product")
    console.log(result)
  if(result){

    setValueData({
      ...valueData,
     Id:result.Id,
     Name:result?.Name,
     Description:result?.Description,
     Price:result?.Price,
     ProductTypeId: result?.ProductTypeId,
     SupplierId: result?.SupplierId,
     Photo: result?.Photo,
     Size: result?.Size,
    })
  }

  // eslint-disable-next-line react-hooks/exhaustive-deps
  },[id])

  function Prev() {
    setBodyAdmin(<Product />);
    setFillerAdmin('PRODUCT');
  }

  const handleChange = (event) => {
    setValueData({ ...valueData, [event.target.name]: [event.target.value].toString() });
  };
  const { enqueueSnackbar } = useSnackbar();
  const [image, setImage] = useState();
  const [urlImage, setUrlimage] = useState(undefined);
  var HandleChange = (e) => {
    const file = e.target?.files[0];
    console.log(urlImage)
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
  const handelUpdate= async()=>{
     
  try {
    console.log(valueData)
    const res = await updateProduct(valueData)
    if(res?.success&&res?.message==='Yes' ){
      enqueueSnackbar('Đa xac nhan', { variant: 'success' });
    }
    else{
      enqueueSnackbar('Loi ', { variant: 'warning' });
    }
  } catch (error) {
    enqueueSnackbar('Cập nhật thất bại', { variant: 'error' });
  }


  }

  return (
    <div className='UpdateCoffee'>
      <Fade in={true} timeout={200} style={{ height: '100%' }}>
        <Paper>
          <button
          style={{width:'fit-content', position:'absolute'}}
            type='button'
            className='btn btn-success d-flex gap-2'
            onClick={() => Prev()}>
            <i
              style={{ fontSize: '1.5rem' }}
              className='fad fa-chevron-circle-left'></i>
            <p className> Quay lại</p>
          </button>
          <h2 className='text-center pt-2 '>Cập nhật sản phẩm </h2>
          <p  style={{width:'80%',margin:'0 auto'}}>Mã sản phẩm (Coffee):{id}</p>
          <div className='dataUpdate'>
          <div className='data--short_text'>
            <div className='form-floating mb-3 inputData'>
              <input
                type='text'
                className='form-control '
                name='Name'
                color='warning'
                value={valueData.Name}
                onChange={handleChange}
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
                onChange={handleChange}
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
                onChange={handleChange}
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
                onChange={handleChange}
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
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Size</label>
            </div>
            </div>
            <div className='data--large_text'>
            <input type='file' id='inputFile' onChange={HandleChange} />
     
            
            <label className='inputFileLabel inputData ' htmlFor='inputFile'>
            <span>Giữ lại hình ảnh cũ <Checkbox defaultChecked /></span> 
              <div className='box_input'>
                <p className='text-center textUpload '>Hình ảnh mô tả</p>
                {image ? <img className='img_preview' src={image.preview} />: 
                valueData?.Photo&&<img className='img_preview' src={valueData?.Photo} />}
                <i className='fad fa-plus-circle iconUpLoad'></i>
              </div>
            </label>
        
            <div className='form-floating inputData' >
              <textarea
                className='form-control'
                placeholder='Leave a comment here'
                id='floatingTextarea2'
                name='Description'
                color='warning'
                value={valueData.Description}
                onChange={handleChange}
                style={{ height: '170px' }}></textarea>
              <label className='description' htmlFor='floatingTextarea2'>
                Nội dung
              </label>
            </div>
          </div>
          
            <div className="button--submit">
              <button type="submit" className='btn btn-success inputData' style={{minWidth:"200px"}} onClick={handelUpdate}>Cập nhật</button>
            </div>
          </div>
        </Paper>
      </Fade>
    </div>
  );
}

export default UpdateCoffee;
