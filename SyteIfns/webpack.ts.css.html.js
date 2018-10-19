﻿/// <binding BeforeBuild='Run - Development' />
var Path = require('path');
var Webpack = require('webpack');
var UglifyJsPlugin = require('uglifyjs-webpack-plugin'); // плагин минимизации
//var MiniCssExtractPlugin = require("mini-css-extract-plugin");
//var OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');
module.exports = {
    mode: "development",
    devServer: {
        overlay: true
    },
    entry: {
        'polyfills': './src/polyfills.ts',
        'app': './src/main.ts'
    },
    output: {
        path: Path.resolve(__dirname, './public'), // путь к каталогу выходных файлов - папка public
        publicPath: '/public/',
        filename: '[name].js' // название создаваемого файла
    },
    resolve: {
        extensions: ['.ts', '.js']
    },
    module: {
        rules: [//загрузчик для ts
            {
                test: /\.ts$/, // определяем тип файлов

                use: [
                    {
                        loader: 'awesome-typescript-loader',
                        options: { configFileName: Path.resolve(__dirname, 'tsconfig.json') }
                    },
                    'angular2-template-loader'
                ]
            }, {
                test: /\.html$/,
                loader: 'html-loader'
            }, {
                test: /\.css$/,
                loader: 'raw-loader'
            }
        ]
    },
    plugins: [
        new Webpack.ContextReplacementPlugin(
            /angular(\\|\/)core/,
            Path.resolve(__dirname, 'src'), // каталог с исходными файлами
            {} // карта маршрутов
        ),
        new UglifyJsPlugin()
    ],
    devtool: 'source-map'
};

