import axios from 'axios';
export const getNews= async(numList)=>{
      try {
        const res = await axios('/news');
        return res?.data.slice(0, numList);
      } catch (error) {
          
      }
}
export const getProductType= async()=>{
    try {
        const res = await axios('/ProductTypes');
      return res?.data;

    } catch (error) {
        
    }
}
export const getProducts= async()=>{
    try {
        const res = await axios('/products');
      return res?.data;
    } catch (error) {
        
    }
}
//  
export const CheckoutData = async data=> {
  try {
    const response = await axios({
      method: 'post',
      url: '/bill/purchase',
      data:data
    })
   console.log(response)
  } catch (error) {
   
  }
 
};