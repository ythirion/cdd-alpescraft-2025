import { Sm } from '../src/main';
import { loadInstructions, calculateResult } from '.';

// Advent of code instructions available here : https://adventofcode.com/2021/day/2
describe('submarine should move', function () {
    test('on given text instructions', () => {
        const submarine = new Sm(0, 0);
        submarine.mv(loadInstructions());

        expect(calculateResult(submarine)).toBe(1690020);
    })
})
