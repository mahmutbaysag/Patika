import { createContext, useContext, useState,useEffect } from "react";
import axios from 'axios'

const WeatherContext = createContext();

export const WeatherProvider = ({children}) =>{
    const [wData,setWData] = useState(null);
    const [city,setCity] = useState('Denizli');

    useEffect(() => {
      console.log("wguncel")
      fetchData(setWData,city)
    }, [city])
    
    const values = {
        wData:wData,
        setCity:setCity
    }

    return <WeatherContext.Provider value={values}>{children}</WeatherContext.Provider>
}

export const useWeather = () => useContext(WeatherContext);


const fetchData = async(setWData,city)=>{
    const apiLink = `https://api.weatherapi.com/v1/forecast.json?key=f2fd0f55575e4bf2ad3150144222609&q=${city}&days=8&aqi=no&alerts=no&lang=tr`;
    const data = await axios(apiLink)
    console.log(data)
    setWData(data)
}