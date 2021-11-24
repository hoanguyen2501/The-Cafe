import React, { useContext } from 'react';
import { context } from '../../app/Context';
import Product from './../Product/index';
function UpdateProducts(props) {
    const Context = useContext(context);
    const { setBodyAdmin ,setFillerAdmin} = Context;
    const {id}=props
    function Prev(){
        setBodyAdmin(<Product/>)
        setFillerAdmin('PRODUCT')
    }
    return (
        <div className="UpdateProducts">
            <button type="button" className="btn btn-success" onClick={()=>Prev()} ><i style={{fontSize:"1.5rem"}} className="fad fa-chevron-circle-left"></i></button>
            <h2>UpdateProducts {id}</h2>
            <table>
                
                 <tr>
                    <td><p>Products</p></td>
                    <td><input type="text" value={id}/></td>
                </tr>
                <tr>
                    <td><p>Tên sản phẩm</p></td>
                    <td><input type="text" /></td>
                </tr>
            </table>
        </div>
    );
}

export default UpdateProducts;