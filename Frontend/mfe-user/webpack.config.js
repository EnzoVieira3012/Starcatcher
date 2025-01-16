const { ModuleFederationPlugin } = require("webpack").container;
const HtmlWebpackPlugin = require("html-webpack-plugin");
const path = require("path");

module.exports = {
  entry: "./src/index.jsx",
  mode: "development",
  devServer: {
    port: 4005,
    historyApiFallback: true,
  },
  output: {
    publicPath: 'http://localhost:4005/',
  },
  resolve: {
    extensions: [".js", ".jsx"],
  },
  module: {
    rules: [
      {
        test: /\.jsx?$/,
        exclude: /node_modules/,
        use: {
          loader: "babel-loader",
        },
      },
      {
        test: /\.css$/,
        use: ["style-loader", "css-loader", "postcss-loader"],
      },
      {
        test: /\.(png|jpe?g|gif|svg)$/i,
        type: 'asset/resource',
      },
    ],
  },
  plugins: [
    new ModuleFederationPlugin({
      name: "user",
      filename: "remoteEntry.js",
      exposes: {
        "./DashboardPage": "./src/pages/DashboardPage.jsx",
        "./ProfilePage": "./src/pages/ProfilePage.jsx",
      },
      shared: {
        react: { singleton: true, requiredVersion: '^18.0.0', eager:true },
        'react-dom': { singleton: true, requiredVersion: '^18.0.0' },
        '@reduxjs/toolkit': { singleton: true, requiredVersion: '^1.8.0' },
        'react-redux': { singleton: true, requiredVersion: '^7.2.4' },
        '@apollo/client': { singleton: true, requiredVersion: '^3.0.0' }
      },
    }),
    new HtmlWebpackPlugin({
      template: "./public/index.html",
    }),
  ],
};