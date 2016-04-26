/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {

        var domElement = {
            init: function (type) {
                this.attributes = {};
                this.content = '';
                this.children = [];

                if (!type) {
                    throw new Error();
                }
                if (!(typeof type == typeof'pesho')) {
                    throw new Error();
                }

                if (!/^[a-zA-Z0-9]*$/g.test(type)) {
                    throw new Error();
                }
                this.type = type;
                return this;
            },
            appendChild: function (child) {
                if (typeof child !== typeof 'pesho') {
                    child.parent = this;
                }
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {

                if (!name) {
                    throw new Error();
                }
                else if (!(/^[-a-zA-Z0-9]*$/g.test(name))) {
                    throw new Error();
                } else {
                    this.attributes[name] = value;
                    return this;
                }
            },
            removeAttribute: function (name) {
                if (!this.attributes[name]) {
                    throw new Error();
                }
                delete this.attributes[name];
                return this;
            },
            get innerHTML() {
                function sortAttributes(attributes) {
                    var keys = Object.keys(attributes),
                        i, result = {},
                        len = keys.length;
                    keys.sort();
                    for (i = 0; i < len; i++) {
                        result[keys[i]] = attributes[keys[i]];
                    }
                    return result;
                }

                var innerResult = '',
                    result = '<' + this.type;

                if (Object.keys(this.attributes).length === 0) {
                    result += '>';
                } else {
                    this.attributes = sortAttributes(this.attributes);

                    for (item in this.attributes) {
                        result += ' ' + item + '="' + this.attributes[item] + '"';
                    }
                    result += '>';
                }
                if (this.children.length > 0) {
                    this.children.forEach(function (child) {
                            if (typeof child == typeof 'pesho') {
                                innerResult += child;
                            } else {
                                innerResult += child.innerHTML;
                            }
                        }
                    );
                    result += innerResult + '</' + this.type + '>';
                } else {
                    result += this.content + '</' + this.type + '>';
                }
                return result;
            }
        };
        return domElement;
    }());
    return domElement;
}

module.exports = solve;
