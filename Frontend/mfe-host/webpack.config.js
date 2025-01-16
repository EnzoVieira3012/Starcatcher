const { ModuleFederationPlugin } = require("webpack").container;
const HtmlWebpackPlugin = require("html-webpack-plugin");
const path = require("path");

module.exports = {
  stats: 'detailed',
  entry: "./src/index.jsx",
  mode: "development",
  devServer: {
    port: 4000,
    static: {
      directory: path.join(__dirname, "dist"),
    },
    historyApiFallback: true,
  },
  output: {
    publicPath: "http://localhost:4000/",
  },
  resolve: {
    fallback: {
      "path": require.resolve("path-browserify"),
    },
    extensions: [".js", ".jsx"],
  },
  module: {
    rules: [
      {
        test: /\.jsx?$/,
        exclude: /node_modules/,
        use: {
          loader: "babel-loader",
          options: {
            presets: ["@babel/preset-env", ["@babel/preset-react", {runtime: "automatic"}]],
          },
        },
      },
    ],
  },
  plugins: [
    new ModuleFederationPlugin({
      name: "host",
      remotes: {
        auth: "auth@http://localhost:4001/remoteEntry.js",
        consortium: "consortium@http://localhost:4002/remoteEntry.js",
        quota: "quota@http://localhost:4003/remoteEntry.js",
        clients: "clients@http://localhost:4004/remoteEntry.js",
        user: "user@http://localhost:4005/remoteEntry.js",
      },
      shared: {
        react: { singleton: true, requiredVersion: '^18.0.0' },
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