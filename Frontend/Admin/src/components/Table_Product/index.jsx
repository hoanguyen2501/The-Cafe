import '../stylesTable.scss';
import React, { useState } from 'react';
import PropTypes from 'prop-types';
import ProDetails from './../ProDetails/index';
import Paper from '@mui/material/Paper';
import Fade from '@mui/material/Grow';
import axios from 'axios';
import { useSnackbar } from 'notistack';
import Pagination from '@mui/material/Pagination';
import Stack from '@mui/material/Stack';
Table_Product.propTypes = {
  List: PropTypes.array,
  List_Title_Head: PropTypes.array,
};
Table_Product.defaultProps = {
  List: [],
  List_Title_Head: [],
};
export default function Table_Product(props) {
  const { enqueueSnackbar } = useSnackbar();
  const { List, List_Title_Head, paginate, setPaginate } = props;
  const [open, setOpen] = useState(false);
  const [details, setDetails] = useState({});
  function handleDetaits(params) {
    setOpen(true);
    setDetails(params);
  }

  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await axios.delete(`/product/delete/${id}`).then(function (response) {
        if (response.status === 200) {
          enqueueSnackbar('Xóa thành công', { variant: 'success' });
        } else {
          enqueueSnackbar('Xóa thất bại', { variant: 'warning' });
        }
      });
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
      {' '}
      <Stack className='m-auto' spacing={2}>
        <Pagination
          count={paginate?.count}
          variant='outlined'
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
                  {List_Title_Head.map((item, index) => (
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
                      <p className='text_over' style={{ width: '220px' }}>
                        {item?.Name}
                      </p>
                    </td>

                    <td>{item?.Price} đồng</td>
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
                        data-set={item?.Id}>
                        Cập nhật
                      </button>
                    </td>
                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-warning'
                        data-set={item?.Id}
                        onClick={() =>
                          handleDetaits({
                            Photo: item?.Photo,
                            Id: item?.Id,
                            Name: item?.Name,
                            Description: item?.Description,
                            Price: item?.Price,
                          })
                        }>
                        Xem chi tiết
                      </button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>

            <ProDetails open={open} setOpen={setOpen} Item={details} />
          </div>
        </Paper>
      </Fade>
    </>
  );
}
