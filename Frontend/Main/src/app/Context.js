import { createContext } from 'react';
import { useState } from 'react';

 export const context = createContext();

export default function ContextProvier ({ children }){
  const [checkToken,setCheckToken]=useState( localStorage.getItem('accessToken')||false)
  const [Login,setLogin]=useState({
    name:'Đăng Nhập',
    value:1
    }
    )
    const Item={
      LoginSign:Login,
      setLoginSign:setLogin,
      checkToken,setCheckToken
    }
        
    
  return <context.Provider value={Item}>{children}</context.Provider>;
};
