import Fade from '@mui/material/Grow';
import Pagination from '@mui/material/Pagination';
import Paper from '@mui/material/Paper';
import Stack from '@mui/material/Stack';
import axios from 'axios';
import { useSnackbar } from 'notistack';
import PropTypes from 'prop-types';
import React, { useContext } from 'react';
import { context } from '../../../app/Context';
import '../stylesTable.scss';
import UpdateNews from '../../UpdateComponent/UpdateNews';
TableNews.propTypes = {
  List: PropTypes.array,
  ListTitleHead: PropTypes.array,
};
TableNews.defaultProps = {
  List: [],
  ListTitleHead: [],
};
export default function TableNews(props) {
  const Context = useContext(context);
  const { List, paginate, setPaginate,setFlag} = props;
  const { enqueueSnackbar } = useSnackbar();
  const { setBodyAdmin} = Context;

  const ListTitleHead = [
    { Name: 'Mã số' },
    { Name: 'Tiêu đề' },
    { Name: 'Nội dung' },
    { Name: 'Hình ảnh' },
    { Name: 'Xóa' },
    { Name: 'Cập nhật' },
  ];


  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await axios.delete(`/product/delete/${id}`).then(function (response) {
        if (response.status === 200) {
          setFlag(true)
          enqueueSnackbar('Xóa thành công', { variant: 'success' });
        } else {
          enqueueSnackbar('Xóa thất bại', { variant: 'warning' });
        }
      });
    }
  };
  function changePage(page) {
    setFlag(true)
    setPaginate({
      ...paginate,
      page: page,
    });
  }
  function HandelUpdate(id) {
        setBodyAdmin(<UpdateNews id={id} />);
  }
  return (
    <>
      {' '}
      <Stack className='m-auto' spacing={2}>
        <Pagination
          color='primary'
          count={paginate?.count}
          onChange={(e, value) => changePage(value)}
        />
      </Stack>
      <Fade in={true} timeout={400} className='body_page'>
        <Paper>
          <div>
            <table className='itemTable'>
              <thead className='headerTable'>
                <tr>
                  <th>STT</th>
                  {ListTitleHead?.map((item, index) => (
                    <th key={index}>{item?.Name}</th>
                  ))}
                </tr>
              </thead>
              <tbody>
                {List?.map((item, index) => (
                  <tr key={index} id={item?.Id}>
                    <td>{index + 1}</td>
                    <td>{item?.Id}</td>
                    <td>
                      <p className='text_over'>
                        {item?.Title}
                      </p>
                    </td>
                    <td>
                      <p className='text_over'>
                        {item?.Content}
                      </p>
                    </td>
                    <td>
                      <p className='text_over'>
                        {item?.Thumbnail}
                      </p>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-danger'
                        data-set={item?.Id}
                        onClick={() => HandleDelete(item?.Id)}>
                        Xóa
                      </button>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-success'
                        onClick={() => HandelUpdate(item?.Id)}
                        data-set={item?.Id}>
                        Cập nhật
                      </button>
                    </td>
                  
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </Paper>
      </Fade>
    </>
  );
}
