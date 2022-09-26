import React,{useEffect, useState} from 'react'
import { useWeather } from '../context/WeatherContext'

function Weather() {
    const {wData,setCity} = useWeather();
    const [wd,setWD] = useState();
    const [cityy,setCityy] = useState('Denizli');

    useEffect(() => {
        setWD(wData)
        setCity(cityy)
    }, [wData,wd,cityy,setCity,setWD])

    const dayName =(date)=>{
        var a = new Date(date);
        var days = new Array(7);
        days[0] = "Pazar";
        days[1] = "Pazartesi";
        days[2] = "Salı";
        days[3] = "Çarşamba";
        days[4] = "Perşembe";
        days[5] = "Cuma";
        days[6] = "Cumartesi";
        return days[a.getDay()];
    }
    
  return (
    <div className='container-sm col-md-7 mt-5'>
        <h3 className='Display-1'>Weather App</h3>
        <hr />
        <div className=' rounded-1 p-3' style={{backgroundColor:"#F6F0F7"}}>
            <select className='form-control' value={cityy} onChange={(e)=>{setCityy(e.target.value);console.log("gun")}} >
                {['Denizli','İzmir','İstanbul','Burdur']
                .map((x,i)=><option key={i} value={x}>{x}</option>)}
            </select>
        </div>
        <div className='p-2 mt-3 d-flex justify-content-between'>
            {wd && wd.data.forecast.forecastday.map((x,i)=>
            <div key={i} style={{width:"100px"}} className="card rounded-0 border-0">
                <div className='bg-white border-0 rounded-0 card-header m-0 p-0 text-center fw-bolder' style={{color:"#CECECE",fontFamily:'sans-serif'}}>{dayName(x.date)}</div>
                <div className='bg-white border-0 rounded-0 card-body m-0 p-0 text-center'><img src={x.day.condition.icon} alt={x.day.condition.text} /></div>
                <div className='bg-white border-0 rounded-0 card-footer m-0 p-0 text-center'>{x.day.maxtemp_f} <span style={{color:"#CECECE"}}>{x.day.mintemp_f}</span> </div>
            </div>)
            }
            
        </div>
    </div>
  )
}

export default Weather