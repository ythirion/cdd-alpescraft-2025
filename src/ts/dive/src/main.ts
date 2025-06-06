export class I {
    constructor(public readonly t: string, public readonly x: number) {}

    static fromText(text: string): I {
        const split = text.split(" ");
        return new I(split[0], parseInt(split[1]));
    }
}

export class P {
    constructor(public readonly hrz: number, public readonly dpt: number){}

    wHrz(nHrz: number): P {
        return new P(nHrz, this.dpt);
    }

    wDpt(nDpt: number): P {
        return new P(this.hrz, nDpt);
    }
}

export class Sm {
    private pstn: P;
    private mvt: Map<string, Function> = new Map([
        ["down", (i: I) => this.pstn.wDpt(this.pstn.dpt + i.x)],
        ["up", (i: I) => this.pstn.wDpt(this.pstn.dpt - i.x)]
    ]);

    constructor(hrz: number, dpt: number) {
        this.pstn = new P(hrz, dpt);
    }

    private np(i: I): P {
        if(this.mvt.has(i.t)) {
            return this.mvt
                .get(i.t)
                ?.call(this, i);
        }
        return this.pstn.wHrz(this.pstn.hrz + i.x);
    }

    mv(i: Array<I>): void {
        i.forEach(i => this.pstn = this.np(i));
    }

    cp(): P {
        return this.pstn;
    }
}