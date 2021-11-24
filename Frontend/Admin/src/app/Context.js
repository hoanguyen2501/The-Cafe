import { createContext, useState } from 'react';

export const context = createContext();
const ContextProvider= ({children})=> {
  const [fitterAdmin, setFillerAdmin] = useState('0');
  const [bodyAdmin, setBodyAdmin] = useState(undefined);
  const value = {
    fitterAdmin,
    setFillerAdmin,
    bodyAdmin, setBodyAdmin
  };
  return <context.Provider value={value}>{children}</context.Provider>;
}
export default ContextProvider;
