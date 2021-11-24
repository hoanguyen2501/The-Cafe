import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import PropTypes from 'prop-types';
import React from 'react';
import '../stylesTable.scss';
import Pagination from '@mui/material/Pagination';
import Stack from '@mui/material/Stack';
Table_Person.propTypes = {
  List: PropTypes.array,
  List_Title_Head: PropTypes.array,
};
Table_Person.defaultProps = {
  List: [],
  List_Title_Head: [],
};
export default function Table_Person(props) {
  const { List, List_Title_Head, paginate, setPaginate } = props;
  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await document.getElementById(`${id}`).remove();
    }
  };
  function changePage(page) {
    setPaginate({
      ...paginate,
      page: page,
    });
  }
  return (
    <>
      <Stack className='mt-4' spacing={2}>
        <Pagination
          count={paginate?.count}
          variant='outlined'
          onChange={(e, value) => changePage(value)}
        />
      </Stack>{' '}
      <Fade in={true} timeout={400} className='body_page'>
        <Paper>
          <div>
            <table className='itemTable'>
              <thead className='headerTable'>
                <tr>
                  <th>STT</th>
                  {List_Title_Head.map((item, index) => (
                    <th key={index}>{item?.Name}</th>
                  ))}
                </tr>
              </thead>
              <tbody>
                {List?.map((item, index) => (
                  <tr key={index} id={index}>
                    <td>{index + 1}</td>
                    <td>{item?.Id}</td>
                    <td className='text_over'>{item?.Name}</td>
                    <td>{item?.Address}</td>
                    <td className='text_over'>{item?.Phone}</td>

                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-danger'
                        data-set={item?.Id}
                        onClick={() => HandleDelete(index)}>
                        Xóa
                      </button>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-success'
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
