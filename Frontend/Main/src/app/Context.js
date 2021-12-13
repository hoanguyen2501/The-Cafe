import { createContext } from 'react';
import { useState } from 'react';

 export const context = createContext();

export default function ContextProvier ({ children }){
  const [checkToken,setCheckToken]=useState( localStorage.getItem('accessToken')||false)
  const [address,setAddress]=useState({
    Photo:
    'https://minio.thecoffeehouse.com/images/tch-web-order/Delivery2.png',
  Address: '',
  TitleDelivery: 'Giao hàng',
  PlaceHolder: 'Nhập địa chỉ giao hàng',
  })
  const [Login,setLogin]=useState({
    name:'Đăng Nhập',
    value:1
    }
    )
    const Item={
      LoginSign:Login,
      setLoginSign:setLogin,
      checkToken,setCheckToken,
      address,setAddress
    }
        
    
  return <context.Provider value={Item}>{children}</context.Provider>;
};
