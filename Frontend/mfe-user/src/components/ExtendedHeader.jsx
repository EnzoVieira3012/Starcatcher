import React from "react";
import backIcon from "../assets/back_icon.png";
import starcatcherLogoIcon from "../assets/starcatcher_logo_icon.png";
import extendedDiviserIcon from "../assets/extended_diviser_icon.png";
import consortiumIcon from "../assets/consortium_icon.png";
import clientIcon from "../assets/client_icon.png";
import profileIcon from "../assets/profile_icon.png";
import logoutIcon from "../assets/logout_icon.png";

const ExtendedHeader = ({ onClose, setCurrentPage }) => {
  return (
    <div
      className="fixed top-0 left-0 h-screen w-64 bg-[#1E2261] text-white flex flex-col justify-between items-start py-4 px-4 shadow-lg z-50"
    >
      <div className="flex flex-col items-start w-full">
        <div className="mb-4">
          <img
            src={backIcon}
            alt="Back Icon"
            onClick={onClose}
            className="w-8 h-8 transition duration-200 ease-in-out hover:scale-110 hover:filter hover:brightness-150 hover:hue-rotate-[90deg] focus:outline-none focus:scale-110 focus:brightness-150 focus:hue-rotate-[90deg] cursor-pointer"
          />
        </div>
        <div className="mb-4">
          <img
            src={starcatcherLogoIcon}
            alt="Starcatcher Logo Icon"
            style={{
              maxWidth: "100%",
              height: "auto",
              display: "block",
            }}
          />
        </div>
        <div className="mb-8 w-full">
          <img
            src={extendedDiviserIcon}
            alt="Extended Divider Icon"
            style={{
              maxWidth: "100%",
              height: "auto",
              display: "block",
            }}
          />
        </div>
        <div
          className="mb-4 flex items-center gap-4 group cursor-pointer transition duration-200 ease-in-out hover:brightness-150 hover:scale-105"
          onClick={() => setCurrentPage("consortiums")}
        >
          <img
            src={consortiumIcon}
            alt="Consortium Icon"
            className="w-8 h-8 group-hover:filter group-hover:brightness-150 transition duration-200 ease-in-out"
          />
          <span className="text-sm font-medium group-hover:text-gray-300 transition duration-200 ease-in-out">
            Consórcios
          </span>
        </div>
        <div
          className="mb-4 flex items-center gap-4 group cursor-pointer transition duration-200 ease-in-out hover:brightness-150 hover:scale-105"
          onClick={() => setCurrentPage("clients")}
        >
          <img
            src={clientIcon}
            alt="Client Icon"
            className="w-8 h-8 group-hover:filter group-hover:brightness-150 transition duration-200 ease-in-out"
          />
          <span className="text-sm font-medium group-hover:text-gray-300 transition duration-200 ease-in-out">
            Clientes
          </span>
        </div>
      </div>
      <div className="flex flex-col items-start w-full">
        <div className="mb-4 w-full">
          <img
            src={extendedDiviserIcon}
            alt="Extended Divider Icon"
            style={{
              maxWidth: "100%",
              height: "auto",
              display: "block",
            }}
          />
        </div>
        <div
          className="mb-4 flex items-center gap-4 group cursor-pointer transition duration-200 ease-in-out hover:brightness-150 hover:scale-105"
          onClick={() => setCurrentPage("profile")}
        >
          <img
            src={profileIcon}
            alt="Profile Icon"
            className="w-8 h-8 group-hover:filter group-hover:brightness-150 transition duration-200 ease-in-out"
          />
          <span className="text-sm font-medium group-hover:text-gray-300 transition duration-200 ease-in-out">
            Perfil
          </span>
        </div>
        <div
          className="mb-4 flex items-center gap-4 group cursor-pointer transition duration-200 ease-in-out hover:brightness-150 hover:scale-105"
          onClick={() => setCurrentPage("login")}
        >
          <img
            src={logoutIcon}
            alt="Logout Icon"
            className="w-8 h-8 group-hover:filter group-hover:brightness-150 transition duration-200 ease-in-out"
          />
          <span className="text-sm font-medium group-hover:text-gray-300 transition duration-200 ease-in-out">
            Sair
          </span>
        </div>
      </div>
    </div>
  );
};

export default ExtendedHeader;