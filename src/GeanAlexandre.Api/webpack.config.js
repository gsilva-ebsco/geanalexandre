const Path = require('path')
const Webpack = require('webpack')
const HtmlWebpackPlugin = require('html-webpack-plugin')
const ExtractTextPlugin = require("extract-text-webpack-plugin")
const CleanWebpackPlugin = require('clean-webpack-plugin')

let getPathFromRoot = path => Path.join(__dirname, path)

module.exports = {
    devtool: 'cheap-module-eval-source-map',
    entry: {
        'polyfills': getPathFromRoot('app/polyfills.ts'),
        'vendor': getPathFromRoot('app/vendor.ts'),
        'app': getPathFromRoot('app/main.ts')
    },
    output: {
        path: getPathFromRoot('wwwroot'),
        filename: '[name].bundle.js',
        chunkFilename: '[id].chunk.js',
        publicPath: '/',
    },
    resolve: {
        extensions: ['.ts', '.tsx', '.js'] // note if using webpack 1 you'd also need a '' in the array as well
    },
    module: {
        loaders:
        [
            {
                test: /\.ts$/,
                loaders: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: { configFileName: 'tsconfig.json' }
                    }, 'angular2-template-loader'
                ]
            },
            {
                test: /\.html$/,
                loader: 'html-loader'
            },
            {
                test: /\.css$/,
                use: ExtractTextPlugin.extract({
                    fallback: "style-loader",
                    use: "css-loader"
                })
            },
            {
                test: /.(ttf|otf|eot|svg|woff(2)?)(\?[a-z0-9]+)?$/,
                use: [{
                    loader: 'file-loader',
                    options: {
                        name: '[name].[ext]',
                        outputPath: 'fonts/',    // where the fonts will go
                        publicPath: '../'       // override the default path
                    }
                }]
            },
            {
                test: /\.(png|jpg|gif)$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].[ext]',
                            outputPath: 'img/',    // where the fonts will go
                            publicPath: '../'       // override the default path
                        }
                    }
                ]
            }
        ]
    },
    plugins: [
        new Webpack.ProvidePlugin({
            $: "jquery",
            jquery: "jQuery",
            "windows.jQuery": "jquery"
        }),
        new HtmlWebpackPlugin({
            filename: 'index.html',
            template: getPathFromRoot('app/index.html')
        }),
        new ExtractTextPlugin("css/styles.css"),
        new CleanWebpackPlugin('wwwroot')
    ]
}
