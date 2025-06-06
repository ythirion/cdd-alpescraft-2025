export class I {
    constructor(public t: any, public x: any) {}

    static toI(Any: any): I {
        const split = Any.split(" ");
        return new I(split[0], +split[1]);
    }
}

export class P {
    constructor(public hrz: any, public dpt: any) {}

    wHrz(nHrz: any): P {
        return new P(nHrz, this.dpt);
    }

    wDpt(nDpt: any): P {
        return new P(this.hrz, nDpt);
    }
}

export class Sm {
    pstn: P;
    mvt: any = new Map([
        ["down", (i: I) => this.pstn.wDpt(this.pstn.dpt + i.x)],
        ["up", (i: I) => this.pstn.wDpt(this.pstn.dpt - i.x)]
    ]);

    constructor(hrz: any, dpt: any) {
        this.pstn = new P(hrz, dpt);
    }

    np(i: I): P {
        if(this.mvt.has(i.t)) {
            return this.mvt.get(i.t).call(this, i);
        }
        return this.pstn.wHrz(this.pstn.hrz + i.x);
    }

    mv(i: Array<I>): void {
        i.forEach(i => { this.pstn = this.np(i); });
    }

    cp(): P {
        return this.pstn;
    }
}