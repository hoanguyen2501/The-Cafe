import axios from "axios";
import paginate from 'paginate-array';

// ================================Customers=================================
export const getCustomeId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getCustomers= async(pag)=>{
    const response = await axios.get("/customer");
    if (response.data) {
      const {page,size}=pag;
      const currPage = paginate(response?.data, page, size);
  
      return currPage;
      
    }
    return [];

}
// ================================News=================================
export const getNewId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getNews= async(pag)=>{

  const response = await axios.get("/news");
  if (response.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}

// ================================Product=================================
export const getProductId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getProductTypes= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
export const getProducts= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
export const updateProduct = async datafrom => {
  try {
 
    const response = await axios.get({
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
// ================================Accounts=================================

export const getAccounts= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);

    return currPage;
    
  }
  return [];

}
// ================================Employees=================================
export const getSaleId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getSales= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
// ================================Suppliers=================================
export const  getSupplierId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getSupplier= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
// ================================Suppliers=================================
export const getRoleId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}

export const getRole= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
// ================================Bill=================================
export const getBillId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getBill= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}

// ================================Store=================================
export const getStoreId= async(id,router)=>{

  const response = await axios.get(`${router}/${id}`);
  if (response.data) {
    return response.data;
    
  }
  return [];

}
export const getStore= async(pag,router)=>{

  const response = await axios.get(router);
  if (response?.data) {
    const {page,size}=pag;
    const currPage = paginate(response?.data, page, size);
    return currPage;
    
  }
  return [];

}
// ==============================Delete============================
export const DeleteId= async(id,router)=>{

  const response = await axios.delete(`${router}/${id}`);
  return response;

}