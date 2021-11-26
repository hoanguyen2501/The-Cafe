import Fade from '@mui/material/Grow';
import Pagination from '@mui/material/Pagination';
import Paper from '@mui/material/Paper';
import Stack from '@mui/material/Stack';
import axios from 'axios';
import { useSnackbar } from 'notistack';
import PropTypes from 'prop-types';
import React, { useContext, useState } from 'react';
import { context } from '../../app/Context';
import ProDetails from '../ProDetails/index';
import '../stylesTable.scss';
import UpdateBook from '../UpdateComponent/UpdateBook';
import UpdateCoffee from '../UpdateComponent/UpdateCoffee';
import UpdateNews from './../UpdateComponent/UpdateNews';
TableProduct.propTypes = {
  List: PropTypes.array,
  ListTitleHead: PropTypes.array,
};
TableProduct.defaultProps = {
  List: [],
  ListTitleHead: [],
};
export default function TableProduct(props) {
  const Context = useContext(context);
  const { List, ListTitleHead, paginate, setPaginate,setFlag} = props;
  const { enqueueSnackbar } = useSnackbar();
  const { setBodyAdmin ,TypeDataPro} = Context;
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
    switch (TypeDataPro) {
      case 'BOOKS': {
        setBodyAdmin(<UpdateBook id={id} />);
 
        break;
      }
      case 'COFFEES': {
        setBodyAdmin(<UpdateCoffee id={id} />);
        break;
      }
      default: {
        setBodyAdmin(<UpdateNews id={id} />);
      }
    }
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
                  {ListTitleHead.map((item, index) => (
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
                        {item?.Name}
                      </p>
                    </td>

                    <td> {item?.Price.toLocaleString(undefined, {
                    minimumFractionDigits: 0,
                  })} đ</td>
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
                        onClick={() => HandelUpdate(item?.Id, TypeDataPro)}
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