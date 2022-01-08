module.exports = {
    aliases: {
        "@node_modules": "./node_modules",
    },
    clean: [
        "@libs"
    ],
    mappings: {
        "@node_modules/chart.js/dist/Chart.js": "@libs/ChartJs/"
    }
};
