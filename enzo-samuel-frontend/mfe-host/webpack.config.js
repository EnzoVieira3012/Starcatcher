const { ModuleFederationPlugin } = require('webpack').container;
const HtmlWebpackPlugin = require('html-webpack-plugin');
const path = require('path');

module.exports = {
  entry: './src/index.js',
  mode: 'development',
  devServer: {
    port: 4000,
    historyApiFallback: true,
  },
  output: {
    publicPath: 'http://localhost:4000/',
  },
  module: {
    rules: [
      {
        test: /\.jsx?$/,
        exclude: /node_modules/,
        use: {
          loader: 'babel-loader',
          options: {
            presets: ['@babel/preset-env', '@babel/preset-react'],
          },
        },
      },
    ],
  },
  plugins: [
    new ModuleFederationPlugin({
      name: 'host',
      remotes: {
        auth: 'auth@http://localhost:4001/remoteEntry.js',
        consortium: 'consortium@http://localhost:4002/remoteEntry.js',
        quota: 'quota@http://localhost:4003/remoteEntry.js',
        clients: 'clients@http://localhost:4004/remoteEntry.js',
        user: 'user@http://localhost:4005/remoteEntry.js',
      },
      shared: ['react', 'react-dom'],
    }),
    new HtmlWebpackPlugin({
      template: './public/index.html',
    }),
  ],
};