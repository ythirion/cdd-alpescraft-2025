import * as fs from 'fs';
import { I } from '../src/main';
import { Sm } from '../src/main';

export function loadInstructions(): Array<I> {
    return fs.readFileSync('./tests/submarine.txt', 'utf-8')
        .split(/\r?\n/)
        .map(line => I.toI(line));
}

export function calculateResult(submarine: Sm): number {
    return submarine.cp().dpt * submarine.cp().hrz;
}