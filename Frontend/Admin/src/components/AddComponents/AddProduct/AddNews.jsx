/* eslint-disable jsx-a11y/alt-text */
import { useSnackbar } from 'notistack';
import React, { useState } from 'react';
import './styles/AddNew.scss';
import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import { addNews } from '../../../app/ApiResult';
function AddNew(props) {
  const [valueData, setValueData] = useState({
    Title: '',
    Thumbnail: '',
    Content: '',
  });

  
  const handleChange = (event) => {
    setValueData({ ...valueData, [event.target.name]: event.target.value});
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
  const HandleUpload = async () => {
    console.log(valueData);
    const res = await addNews(valueData);
  
    if (res?.success) {
      enqueueSnackbar('Tải lên thành công', { variant: 'success' });
    } else {
      enqueueSnackbar('Hãy chọn tệp tin', { variant: 'warning' });
    }
  };
  return (
    <div className='AddNew'>
       <Fade in={true} timeout={200} style={{ height: '100%' }}>
        <Paper>
      <h2 className='text-center pt-2'>Thêm báo mới </h2>

      <div className='dataUpdate'>
        <div className='form-floating mb-3 inputData'>
          <input
            type='text'
            className='form-control '
            name='Title'
            color='warning'
            value={valueData.Title}
            onChange={handleChange}
          />
          <label htmlFor='floatingInput'>Tiêu đề</label>
        </div>

     

        <input type='file' id='inputFile' onChange={HandleChange} />
        <label className='inputFileLabel label--input inputData ' htmlFor='inputFile'>
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
            name='Content'
            color='warning'
            value={valueData.Content}
            onChange={handleChange}
            style={{ height: '200px' }}></textarea>
          <label className="Content" for='floatingTextarea2'>Nội dung</label>
        </div>
        
        <div className="button__submit">
              <button type="submit" className='btn btn-success inputData' style={{minWidth:"200px"}} onClick={HandleUpload}>Thêm báo</button>
            </div>
      </div>
      </Paper>
      </Fade>
    </div>
  );
}

export default AddNew;
