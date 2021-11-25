/* eslint-disable jsx-a11y/alt-text */
import React from 'react';
// import { storage } from '../firebase_uploadimg';
//"firebase": "^4.8.0",
import { useState } from 'react';
import { useSnackbar } from 'notistack';
import './styles.scss';
function AddProduct(props) {
  // const { router } = props;
  const { enqueueSnackbar } = useSnackbar();
  const [image, setImage] = useState();
  const [valueData, setValueData] = useState({
    Id: '',
    Title: '',
    Photo: '',
    Description: '',
    Price: '',
  });
  const [urlImage, setUrlimage] = useState(undefined);
  const handleChange = (event) => {
    setValueData({ ...valueData, [event.target.name]: [event.target.value] });
  };
  var HandleChangeImg = (e) => {
    const file = e.target.files[0];
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
  };
  const HandleUpload = () => {
    if (image) {
      enqueueSnackbar('Tải lên thành công', { variant: 'success' });
      // const UploadTask = storage.ref(`imageProducts/${image.name}`).put(image);
      // UploadTask.on(
      //   'state_changed',
      //   (snapshot) => {},
      //   (error) => {
      //     console.log(error);
      //   },
      //   () => {
      //     storage
      //       .ref('imageProducts')
      //       .child(image.name)
      //       .getDownloadURL()
      //       .then((url) => {
      //         setUrlimage(url);
      //         console.log('Image:', urlImage);
      //         enqueueSnackbar('Tải lên thành công', { variant: 'success' });
      //       })
      //       .catch((error) => {
      //         enqueueSnackbar('Tải lên thất bại', { variant: 'error' });
      //       });
      //   }
      // );
    } else {
      enqueueSnackbar('Hãy chọn tệp tin', { variant: 'warning' });
    }
  };
  return (
    <div className='AddProduct'>
         <div className='form-floating mb-3 inputData title'>
              <input
                type='text'
                className='form-control '
                name='Author'
                color='warning'
                value={valueData.Author}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Tác giả</label>
            </div>
            <div className='form-floating mb-3 inputData price'>
              <input
                type='text'
                className='form-control '
                name='Publish'
                color='warning'
                value={valueData.Publish}
                onChange={handleChange}
              />
              <label htmlFor='floatingInput'>Nhà xuất bản</label>
            </div>
            
    
      <input type='file' id='inputFile' onChange={HandleChangeImg} />
      <label htmlFor='inputFile'>
        <p style={{margin:'15px',position:'absolute',color:'#747373'}}>Hình ảnh mô tả</p>
        <div className='box_input '>
          {image && <img className='img_preview' src={image.preview} />}
          <i className='fad fa-plus-circle iconUpLoad'></i>
        </div>
      </label>

      <div className='form-floating inputData description'>
              <textarea
                className='form-control'
                placeholder='Leave a comment here'
                id='floatingTextarea2'
                name='Description'
                color='warning'
                value={valueData.Description}
                onChange={handleChange}
                style={{ height: '200px' }}></textarea>
              <label className='description' htmlFor='floatingTextarea2'>
                Nội dung
              </label>
            </div>

      <button
        type='button'
        onClick={HandleUpload}
        className='btn_submit btn btn-warning'>
        Tải lên
      </button>
    </div>
  );
}

export default AddProduct;
