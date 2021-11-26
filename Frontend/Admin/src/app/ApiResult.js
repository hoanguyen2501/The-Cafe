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
export const getProducts= async(pag,router)=>{

    const response = await axios(router);
    if (response.data) {
      const {page,size}=pag;
      const currPage = paginate(response?.data, page, size);
      console.log(currPage)
      return currPage;
      
    }
    return [];

}
export const getNews= async(pag)=>{

  const response = await axios("/news");
  if (response.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    console.log(currPage)
    return currPage;
    
  }
  return [];

}
export const getProductId= async(id,router)=>{

  const response = await axios(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
// =================================================================

export const updateProduct = async datafrom => {
  try {
 
    const response = await axios({
      method: 'post',
      url: `/product/edit/${datafrom.Id}`,
      data:datafrom
    })

    if (response.status===200) {
     
      return { success: true, message: 'Yes' };
    }
  } catch (error) {
   
     return { success: false, message: 'Fail' };
  }
 
};