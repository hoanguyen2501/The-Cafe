import React, { useState } from "react";
function Demo(){
    function onSubmit(){
        fetch(process.env.)
    }
    return(
        <div className="body_Page">
            <formme onSubmit={this.onSubmit}>
                <input type="text" name="DepartmentName" placeholder="DepartmentName"/>
                <button type="submit">submit</button>
            </formme>
        </div>
    )
} export default Demo;