const { copyLibs } = require('gulp-copy-libs')
const libsConfig = [
    {
        outputDirectory: 'wwwroot/libs/chartjs',
        inputFiles: 'node_modules/chart.js/dist/*.js'
    }
];

exports.default = () => {
    return copyLibs(libsConfig);
};