import React, { useEffect } from 'react';
import Demo from '../../components/demoForm';

NotFound.propTypes = {
    
};

function NotFound(props) {
    useEffect(() => {
        window.scrollTo(0, 0)
      }, [])
    return (
        <div>
            <p>NotFound</p>
            <Demo></Demo>
        </div>
    );
}

export default NotFound;