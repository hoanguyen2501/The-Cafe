import '../stylesTable.scss';
import React from 'react';
import PropTypes from 'prop-types';
import Paper from '@mui/material/Paper';
import Fade from '@mui/material/Grow';
import Pagination from '@mui/material/Pagination';
import Stack from '@mui/material/Stack';
TableBill.propTypes = {
  List: PropTypes.array,
  ListTitleHead: PropTypes.array,
};
TableBill.defaultProps = {
  List: [],
  ListTitleHead: [],
};
export default function TableBill(props) {
  const { List, ListTitleHead, paginate, setPaginate, Type ,setFlag} = props;
  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await document.getElementById(`${id}`).remove();
    }
  };
  function changePage(page) {
    setFlag(true)
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
          color="primary"
          onChange={(e, value) => changePage(value)}
        />
        </Stack>
     
      <Fade in={true} timeout={400} className='body_page'>
        <Paper>
          <div>
            <table className='itemTable'>
              <thead className='headerTable'>
                <tr>
                <th >STT</th>
                  {ListTitleHead.map((item, index) => (
                    <th key={index}>{item?.Name}</th>
                  ))}
                </tr>
              </thead>
              <tbody>
                {List.map((item, index) => (
                  <tr key={index} id={item.id}>
                    <td>{index+1}</td>
                    <td>{item.invoice}</td>
                    <td className='text_over'>{item.name}</td>
                    <td>{item.company}</td>
                    <td>{item.amount}</td>
                    <td className='status status-delivering'>{item.status}</td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-danger'
                        data-set={item.id}
                        onClick={() => HandleDelete(item.id)}>
                        Hủy
                      </button>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-success'
                        data-set={item.id}>
                        Hoàn Tất
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
