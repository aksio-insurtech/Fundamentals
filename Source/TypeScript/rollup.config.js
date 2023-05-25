// Copyright (c) Aksio Insurtech. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

import typescript from "rollup-plugin-typescript2";
import commonjs from "rollup-plugin-commonjs";
import external from "rollup-plugin-peer-deps-external";
import pkg from "./package.json" assert { type: 'json' };

export default {
    input: "index.ts",
    output: [
        {
            file: pkg.main,
            format: "cjs",
            exports: "named",
            sourcemap: true
        },
        {
            file: pkg.module,
            format: "es",
            exports: "named",
            sourcemap: true
        }
    ],
    plugins: [
        external(),
        commonjs(),
        typescript({
            exclude: "for_**/**/*",
            tsconfig: './tsconfig.json',
            clean: true
        })
    ]
};
