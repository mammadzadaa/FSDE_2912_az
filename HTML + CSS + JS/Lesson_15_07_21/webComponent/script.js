class MyTime extends HTMLElement{
    constructor(){
        super();
        console.log('constructor')
    }

    connectedCallback(){
        console.log('connected')

        this.format = JSON.parse(this.getAttribute('hour12'))
        console.log(this.format)

        this.timerId = setInterval(()=>{

            this.innerHTML = new Date().toLocaleTimeString('az-AZ',{hour12: this.format});
        },1000)

    }

    disconnectedCallBack(){
        clearInterval(this.timerId)
    }

}

customElements.define('my-time',MyTime)