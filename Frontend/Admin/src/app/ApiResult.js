import axios from "axios";
import paginate from 'paginate-array';
export const getCustomers= async(pag)=>{

    const response = await axios("/customer");
    if (response.data) {
      const {page,size}=pag;
      const currPage = paginate(response?.data, page, size);
      return currPage;
      
    }
    return [];

}
export const getProduct= async(pag)=>{

    const response = await axios("/products");
    if (response.data) {
      const {page,size}=pag;
      const currPage = paginate(response?.data, page, size);
      console.log(currPage)
      return currPage;
      
    }
    return [];

}