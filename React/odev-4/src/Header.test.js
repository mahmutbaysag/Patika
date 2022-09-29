import {screen,render} from '@testing-library/react'
import React from 'react'

import Header from './Header.js'

test("Header Kontrol",()=>{
    render(<Header />)

    let baslik = screen.findByText("Emoji Search")
    expect(baslik).toBeInTheDocument()
})