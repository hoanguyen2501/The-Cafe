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
        const res = await axios('/ProductType');
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