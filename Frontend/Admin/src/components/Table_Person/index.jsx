import Fade from '@mui/material/Grow';
import Paper from '@mui/material/Paper';
import PropTypes from 'prop-types';
import React from 'react';
import '../stylesTable.scss';

Table_Person.propTypes = {
  List: PropTypes.array,
  List_Title_Head: PropTypes.array,
};
Table_Person.defaultProps = {
  List: [],
  List_Title_Head: [],
};
export default function Table_Person(props) {

  const HandleDelete = async (id) => {
    if (window.confirm('Bạn đã chắc chắn muốn xóa?')) {
      await document.getElementById(`${id}`).remove();
    }
  };
  const { List, List_Title_Head } = props;
  return (
    <>
      {' '}
      <Fade in={true} timeout={400} className='body_page'>
        <Paper>
          <div>
            <table className='itemTable'>
              <thead className='headerTable'>
                <tr>
                <th >STT</th>
                  {List_Title_Head.map((item, index) => (
                    <th key={index}>{item.Name}</th>
                  ))}
                </tr>
              </thead>
              <tbody>
                {List?.map((item, index) => (
                  <tr key={index} id={index}>
                    <td>{index+1}</td>
                    <td>{item.Id}</td>
                    <td className='text_over'>{item.Name}</td>
                    <td>{item.Address}</td>
                    <td className='text_over'>{item.Phone}</td>

                    <td>
                      <button
                        type='button'
                        className='btn btn-outline-danger'
                        data-set={item.id}
                        onClick={() => HandleDelete(index)}>
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
