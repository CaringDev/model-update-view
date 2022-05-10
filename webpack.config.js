var path = require("path");

function resolve(filePath) {
  return path.join(__dirname, filePath)
}

module.exports = {
  devtool: "source-map",
  entry: resolve('./src/App.fs.js'),
  output: {
    filename: 'bundle.js',
    path: resolve('./public'),
  },
  devServer: {
    hot:true,
    static: {
        directory: resolve('./public')
    },
    port: 8080
  },
  module: {
    rules: [
      {
        test: /\.sass$/,
        use: [
          "style-loader",
          "css-loader",
          "sass-loader"
        ]
      }
    ]
  }
};
