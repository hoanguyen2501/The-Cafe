import React, { memo, useContext, useEffect, useState } from "react";
import { Link } from "react-router-dom";
import Footer from "../../components/Footer";
import ListItem from "../../components/ListItem";
import ListItemNews from "../../components/ListItemNews";
import SanPhamTuNha from "../../components/SanPhamTuNha";
import Slider from "../../components/Slider";
import "./styles.scss";
import { context } from './../../app/Context';

function Home() {

  const [check, SetCheck] = useState(); 
  const {checkToken}= useContext(context) 
  function ChangeActive(tem) {
    const Tagactive = document.querySelector(".Tag.active");
    if (Tagactive) {
      Tagactive.classList.remove("active");
    }
    document.querySelector(tem).classList.add("active");
    if (tem === ".Ganday") {
      SetCheck(1);
    } else {
      SetCheck(undefined);
    }
  }

  useEffect(() => {
    SetCheck(undefined);
    window.scrollTo(0, 0);
  }, []);

  return (
    <>
    <div className="Home">
      <div className="body_Page">
        <div className="Slider_Home pt-4">
          <Slider />
        </div>
      <div className="GoiY">
        <div className="Tags">
          <ul>
            <div className="icon">
            <i className="fad fa-lightbulb"></i>
            </div>
            <li className="Tag active goiy" onClick={() => ChangeActive(".goiy")}>
              Nhà gợi ý cho bạn
            </li>
            <li className="Tag Ganday" onClick={() => ChangeActive(".Ganday")}>
              Đặt gần đây
            </li>
          </ul>
        </div>
        <div className="Subject_Tag">
          {check ? (
            <div className="Btn_Login">
             {checkToken?<p style={{lineHeight:'5x',fontWeight:'bold'}}>Chưa có sản phẩm nào</p>:<Link to="/login">Đăng Nhập</Link>}
            </div>
          ) : (
            <ListItem  numList={4} check={true}/>
          )}
        </div>
      </div>
      <div className="SanPham">
        <SanPhamTuNha />
        <div className="TinTuc">
          <ListItemNews numList={8} />
          <Link className="News_goto" to="/News">
            <p>Xem thêm</p> <i className="fas fa-arrow-right"></i>{" "}
          </Link>
        </div>
      </div>
      <div className="gg_play">
        <div className="logo">
          {" "}
          <img style={{borderRadius:"10px"}} src="https://scontent.fsgn5-8.fna.fbcdn.net/v/t39.30808-6/239270325_3045507619056577_531106232057750834_n.jpg?_nc_cat=1&_nc_rgb565=1&ccb=1-5&_nc_sid=09cbfe&_nc_ohc=OasPK9jr5wQAX8-wIrZ&tn=dMWaMxwxfmZqrnfv&_nc_ht=scontent.fsgn5-8.fna&oh=00_AT_O-O85NAP34z1QuXgsnxmr1q5Umn95xPzzhk7XDJ5Cng&oe=61C43F10" alt="" />
        </div>
        <img className="img_large" src="https://i.upimg.com/7JwV3KDET" alt="" />
      </div>
      <div className="Search_Store">
        <div>
          <div>
            <div className="filter_store">
              <div className="search_bottom">
                <i className="fas fa-home color_orange"></i>
                <h5>Tìm Một Cửa Hàng</h5>
              </div>
              <Link to="/Store" className="d-flex color_orange all_store">
                <p>Xem toàn bộ cửa hàng</p>
                <i className="fas fa-arrow-right"></i>
              </Link>
            </div>
          </div>
          <div className="input_store">
            <select name="store" id="input_store">
              <option value="">Chọn Quận</option>
              <option value="1">Quận 1</option>
              <option value="2">Quận 2</option>
              <option value="3">Quận 3</option>
              <option value="4">Quận 4</option>
            </select>
          </div>
        </div>
      </div>
      <Footer />
      </div>
    
    </div>

      </>
  );
}

export default memo(Home);
