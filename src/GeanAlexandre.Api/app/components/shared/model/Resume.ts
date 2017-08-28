export class Resume {
    id: AAGUID;

    fromJSON(json: object): Resume {
        for (let propName in json)
            this[propName] = json[propName];
        return this;
    }
}