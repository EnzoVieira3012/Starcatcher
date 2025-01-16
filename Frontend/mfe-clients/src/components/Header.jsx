import React from "react";
import menuIcon from "../assets/menu_icon.png";
import newmLogoIcon from "../assets/newm_logo_icon.png";
import diviserIcon from "../assets/diviser_icon.png";
import consortiumIcon from "../assets/consortium_icon.png";
import clientIcon from "../assets/client_icon.png";
import profileIcon from "../assets/profile_icon.png";
import logoutIcon from "../assets/logout_icon.png";

const Header = ({ onIconClick }) => {
  return (
    <header className="fixed top-0 left-0 h-screen w-16 bg-[#1E2261] text-white flex flex-col justify-between items-center py-4">
      <div className="flex flex-col items-center">
        <div className="mb-4">
          <img
            src={menuIcon}
            alt="Menu Icon"
            onClick={onIconClick}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
        <div className="mb-4">
          <img src={newmLogoIcon} alt="Newm Logo Icon" className="w-8 h-8" />
        </div>
        <div className="mb-8">
          <img src={diviserIcon} alt="Divider Icon" className="w-8 h-1" />
        </div>
        <div className="mb-4">
          <img
            src={consortiumIcon}
            alt="Consortium Icon"
            onClick={onIconClick}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
        <div className="mb-4">
          <img
            src={clientIcon}
            alt="Client Icon"
            onClick={onIconClick}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
      </div>
      <div className="flex flex-col items-center">
        <div className="mb-4">
          <img src={diviserIcon} alt="Divider Icon" className="w-8 h-1" />
        </div>
        <div className="mb-4">
          <img
            src={profileIcon}
            alt="Profile Icon"
            onClick={onIconClick}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
        <div>
          <img
            src={logoutIcon}
            alt="Logout Icon"
            onClick={onIconClick}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
      </div>
    </header>
  );
};

export default Header;