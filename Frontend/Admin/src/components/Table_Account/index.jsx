import Fade from '@mui/material/Grow';
import Pagination from '@mui/material/Pagination';
import Paper from '@mui/material/Paper';
import Stack from '@mui/material/Stack';
import PropTypes from 'prop-types';
import React from 'react';
import '../stylesTable.scss';
Table_Account.propTypes = {
  List: PropTypes.array,
  List_Title_Head: PropTypes.array,
};
Table_Account.defaultProps = {
  List: [],
  List_Title_Head: [],
};
export default function Table_Account(props) {
  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await document.getElementById(`${id}`).remove();
    }
  };
  const { List, List_Title_Head, paginate, setPaginate } = props;
  function changePage(page) {
    setPaginate({
      ...paginate,
      page: page,
    });
  }
  return (
    <>
      <Stack className='m-auto' spacing={2}>
        <Pagination
          count={paginate?.count}
          variant='outlined'
          onChange={(e, value) => changePage(value)}
        />
      </Stack>
      <Fade direction='up' in={true} timeout={400} className='body_page'>
        <Paper>
          <div>
            <table className='itemTable'>
              <thead className='headerTable'>
                <tr>
                  <th>STT</th>
                  {List_Title_Head.map((item, index) => (
                    <th key={index}>{item.Name}</th>
                  ))}
                </tr>
              </thead>
              <tbody>
                {List.map((item, index) => (
                  <tr key={index} id={item.id}>
                    <td>{index + 1}</td>
                    <td>{item.id}</td>
                    <td className='text_over'>{item.name}</td>
                    <td className='text_over'>{item.gmail}</td>
                    <td className='text_over'>{item.phone}</td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-danger'
                        data-set={item.id}
                        onClick={() => HandleDelete(item.id)}>
                        Xóa
                      </button>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-success'
                        data-set={item.id}>
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
