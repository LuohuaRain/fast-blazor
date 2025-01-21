import * as esbuild from 'esbuild'
import pkg from './package.json' with { type: 'json' }

await esbuild.build({
    entryPoints: [ pkg.source ],
    bundle: true,
    minify: true,
    sourcemap: true,
    logLevel: 'info',
    target: 'es2019',
    format: 'esm',
    outfile: pkg.main,
    legalComments: 'external',
});