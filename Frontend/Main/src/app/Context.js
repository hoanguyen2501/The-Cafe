import { createContext } from 'react';
import { useState } from 'react';

 export const context = createContext();

export default function ContextProvier ({ children }){
  const [Login,setLogin]=useState({
    name:'Đăng Nhập',
    value:1
    }
    )
    const Item={
      LoginSign:Login,
      setLoginSign:setLogin
    }
        
    
  return <context.Provider value={Item}>{children}</context.Provider>;
};
